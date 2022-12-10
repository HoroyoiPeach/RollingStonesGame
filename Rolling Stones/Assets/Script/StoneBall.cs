using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoneBall : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpPower = 30;
    public int itemCount;

    public GameManagerLogic manager;

    bool isJump;

    AudioSource audioSource;
    Rigidbody rigid;

    void Awake()
    {
        itemCount = 0;
        isJump = false;
        rigid  = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump=true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }

        if (Input.GetKey("escape"))
        {
            ExitGame();
        }
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        rigid.AddTorque(new Vector3(h,0,v),ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isJump = false;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
           
            itemCount++;
            audioSource.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }

        else if(other.tag == "Finish")
        {
            if(itemCount == manager.totalItemCount)
            {
                //clear event

                SceneManager.LoadScene("Stage_"+(manager.stageNumber+1).ToString());
            }
            else
            {
                //restrat
                SceneManager.LoadScene("Stage_"+manager.stageNumber.ToString());
            }
        }
        
    }

    public void ExitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit(); // 어플리케이션 종료
    #endif
    }

}
