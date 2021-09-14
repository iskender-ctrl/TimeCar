using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using UnityEngine.UI;
public class Shot : MonoBehaviour
{
    public GameObject arrow;
    public GameObject ClickAnimation;
    //public GameObject NextLevel;
    public GameObject Powers;
    public GameObject time;
    public GameObject ClockFrame;
    public GameObject victory;
    public GameObject ReStart;
    public ParticleSystem Egzoz;
    public ParticleSystem Brake,Brake1,Crash;
    public GameObject Lose;
    public Animator up;
    public Animator down;
    public Animator crash;
    public static bool clickControl;
    public static float counter;
    bool CountControl;
    float ClockTime;
    float timeSpeed;
    public static bool UpControl;
    int count;
    public static float speed;
    float countSpeed;
    bool BladeControl;
    void Start()
    {
        speed = 0;
        countSpeed = 1;
        counter = 10;
        //gameObject.GetComponent<BoxCollider>().enabled = true;
        //NextLevel.gameObject.SetActive(false);
        Powers.gameObject.SetActive(true);
        count = PlayerPrefs.GetInt("money");
        Lose.gameObject.SetActive(false);
        UpControl = false;
        clickControl = false;
        time.gameObject.SetActive(false);
        ClockTime = 1;
        BladeControl = false;
        down.Play("SpeedDown");
        victory.gameObject.SetActive(false);
        ReStart.gameObject.SetActive(false);
        Egzoz.Stop();
        Brake.Stop();
        Brake1.Stop();
        Crash.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        arrow.transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (CountControl == true)
        {
            counter -= countSpeed * Time.deltaTime;
            timeSpeed = 0.1f;
            ClockTime -= timeSpeed * Time.deltaTime;
            ClockFrame.GetComponent<Image>().fillAmount = ClockTime;
            
        }
        Debug.Log(speed);
        if (ClockTime <= 0)
        {
            speed = 0;
            Lose.gameObject.SetActive(true);
           Egzoz.Stop();
            clickControl = false;
            StartCoroutine(timer());
        }
  
        if (Input.GetMouseButtonDown(0)&&clickControl==true)
        {
            countSpeed = 1;
            ClickAnimation.gameObject.SetActive(false);
            Powers.gameObject.SetActive(false);
            UpControl = true;
            CountControl = true;
            Egzoz.Stop();
            time.gameObject.SetActive(true);
            Brake.Play();
            Brake1.Play();
            speed = 2;
            ClockRotator.speed = -200;
            down.Play("SpeedDown");
        }
        if (Input.GetMouseButtonUp(0) && clickControl == true&&UpControl==true)
        {
            ClockRotator.speed = 0;
            speed = 8;
            countSpeed = 0;
            CountControl = false;
            ClickAnimation.gameObject.SetActive(true);
            Powers.gameObject.SetActive(false);
            Egzoz.Play();
            Brake.Stop();
            Brake1.Stop();
            timeSpeed = 0;
            up.Play("SpeedUp");
        }
        
    }
    
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target"&&BladeControl==false)
        {
            speed = 0;
            clickControl = false;
            Egzoz.Stop();
            TrailActive.control = false;
            count += 20;
            PlayerPrefs.SetInt("money", count);
            NextLevel.gameObject.SetActive(true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            time.gameObject.SetActive(false);
        }
        if(other.gameObject.tag=="blade")
        {
            BladeControl = true;
            speed = 0;
            Lose.gameObject.SetActive(true);
            Egzoz.Stop();
            StartCoroutine(timer());
        }
        
       
    }
    */
    
    IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="barier")
        {
            clickControl = false;
            UpControl = false;
            ReStart.gameObject.SetActive(true);
            Crash.Play();
            Egzoz.Stop();
            crash.Play("crash");
            speed = 0;
        }
        if (other.gameObject.tag == "finish")
        {
            clickControl = false;
            UpControl = false;
            victory.gameObject.SetActive(true);
            speed = 0;
        }
    }
}