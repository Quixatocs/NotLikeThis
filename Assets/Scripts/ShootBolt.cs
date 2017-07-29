using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBolt : MonoBehaviour {

    public GameObject lineDrawer;
    private LineRenderer lineRenderer;
    public GameObject spawnPoint;
    public float rechargeDelay = 2.0f;

    public GameObject laserProjectile;

    private bool isShooting = false;

    private WaitForSeconds shootWait;
    private WaitForSeconds beamWait;

    void Start() {
        lineRenderer = lineDrawer.GetComponent<LineRenderer>();
        shootWait = new WaitForSeconds(rechargeDelay);
        beamWait = new WaitForSeconds(0.2f);
    }

    void OnEnable()
    {
        EventManager.alienDetected += shootTarget;
    }

    void OnDisable()
    {
        EventManager.alienDetected -= shootTarget;
    }




    private void shootTarget(Transform target)
    {
        if (!isShooting)
            StartCoroutine(shooting(target));

    }

    private IEnumerator shooting(Transform target) {
        isShooting = true;
        EventManager.invokeSubscribersTo_ShotFired();
        Vector3 spawn = spawnPoint.transform.position;
        Vector3 destination = target.position;


        
        lineDrawer.SetActive(true);
        

        float xdiff = Mathf.Abs(spawn.x - destination.x);
        float ydiff = Mathf.Abs(spawn.y - destination.y);
        float gradient = ydiff / xdiff;

        lineRenderer.SetPosition(0, spawnPoint.transform.position);

        for (int i = 1; i < 3; i++)
        {
            float xpos = 0f;
            float ypos = 0f;

            xpos = Random.Range(spawn.x, destination.x);
            ypos = Random.Range(spawn.y, destination.y);

            Vector3 pointAlongBolt = new Vector3(xpos, ypos, -2f);
            lineRenderer.SetPosition(i, pointAlongBolt);

        }

        lineRenderer.SetPosition(3, target.position);

        laserProjectile.SetActive(true);
        laserProjectile.transform.position = target.position;
        yield return beamWait;
        EventManager.invokeSubscribersTo_ShotAbated();
        laserProjectile.SetActive(false);

        for (int i = 0; i < 4; i++)
        {
            lineRenderer.SetPosition(i, Vector3.zero);

        }

        lineDrawer.SetActive(false);

        yield return shootWait;

        isShooting = false;

    }

}
