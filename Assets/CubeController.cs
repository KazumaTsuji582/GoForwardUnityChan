using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    public AudioClip soundEffect;   //AudioClip�^�̕ϐ���
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  //AudioSource�R���|�[�l���g���擾
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //�^�O��ݒ肵�AUnityChan�ɐG�ꂽ�Ƃ��ȊO�Ȃ�Ό��ʉ���点��
        if (collision.gameObject.tag != "UnityChan")
        {
            audioSource.PlayOneShot(soundEffect);
        }
    }
}
