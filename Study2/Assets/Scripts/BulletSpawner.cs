using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; //������ ź���� ���� ������
    public float spawnerRateMin = 0.5f; // �ּ� ���� �ֱ�
    public float spawnerRateMax = 3f; //�ִ� ���� �ֱ�

    private Transform target; //�߻��� ���
    private float spawnRate; //���� �ֱ�
    private float timeAfterSpawn; //�ֱ� ���� �������� ���� �ð�


#if (false) //�ڷ�ƾ ��� x
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        //ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����
        spawnRate = Random.Range(spawnerRateMin, spawnRateMax);
        //PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform; 
    }

    void Update()
    {
        // timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ������
        if(timeAfterSpawn >=spawnRate)
        {
            //������ �ð��� ����
            timeAfterSpawn = 0f;

            //bulletPrefab�� ��������
            //transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);

            //������ ���� ������ spawnRateMin, spawnRateMax ���̿��� ���� ����;
            spawnRate = Random.Range(spawnerRateMin, spawnRateMax);
        }
    }
#endif
    private void Start()
    {
        spawnRate = Random.Range(spawnerRateMin, spawnerRateMax);
        target = FindObjectOfType<PlayerController>().transform;
        StartCoroutine(BulletSpawn());
    }

    IEnumerator BulletSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnerRateMin, spawnerRateMax);
        }
    }

}
