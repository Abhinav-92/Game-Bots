using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;

    public void FireBulletOnTouch(Vector3 position, Quaternion rotation, int bulletType)
    {
        if(Input.touchCount > 0){
            SpawnBullet(position, rotation, bulletType);
        }
    }

    private void SpawnBullet(Vector3 position, Quaternion rotation, int bulletType)
    {
        if(bulletType == 1)
        {
            Instantiate(bulletPrefab, position, rotation);
        }
        else if(bulletType == 2)
        {
            Instantiate(bulletPrefab, position, rotation);
            StartCoroutine(DelayBetweenBullets(position, rotation, 0.1f));
            StartCoroutine(DelayBetweenBullets(position, rotation, 0.2f));
        }
        else if(bulletType == 3){
            float width = 1.7f;
            float height = 4.5f;
            float theta_r = Mathf.Atan(width/height);
            float theta_l = Mathf.Atan(width/height) - Mathf.PI / 4;

            Quaternion r1 = new Quaternion(0, theta_r, 0, 1);
            Quaternion r2 = new Quaternion(0, theta_r/2, 0, 1);

            Quaternion l1 = new Quaternion(0, theta_l, 0, 1);
            Quaternion l2 = new Quaternion(0, theta_l/2, 0, 1);

            Instantiate(bulletPrefab, position, r1);
            Instantiate(bulletPrefab, position, r2);
            Instantiate(bulletPrefab, position, rotation);
            Instantiate(bulletPrefab, position, l1);
            Instantiate(bulletPrefab, position, l2);

        }
    }

    IEnumerator DelayBetweenBullets(Vector3 position, Quaternion rotation, float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(bulletPrefab, position, rotation);
    }
}
