
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update

    public float damage = 10f;
    public float range = 100f;

    public Camera gunCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Debug.Log("YES");
            Shoot();
        }

    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(gunCam.transform.position, gunCam.transform.forward, out hit, range))
        {

            Target target = hit.transform.GetComponent<Target>();

            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
