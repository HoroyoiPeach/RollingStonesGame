using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public int totalItemCount;
    public int stageNumber;
    public Text TotalItemText;
    public Text PlayerItemText;
    void Awake()
    {
        TotalItemText.text = "/ " + totalItemCount.ToString(); 
    }

   public void GetItem(int count)
    {
        PlayerItemText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stageNumber);
        }
    }

    // Update is called once per frame

}
