using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus_window_instantiator : MonoBehaviour
{
    public GameObject tara_notification1;
    public GameObject tara_notification2;
    [SerializeField] private GameObject virus_window_1;
    [SerializeField] private GameObject virus_window_2;
    [SerializeField] private GameObject virus_window_3;
    [SerializeField] private GameObject virus_window_4;
    [SerializeField] private GameObject virus_window_5;
    private GameObject virus_windows;
    private GameObject sound_manager;

    private float pop_up_speed;
    private float next_pop_up_time;

    public bool first_dialogue_box_closed = false;
    public bool popup_windows_cleaned = false;

    public bool tara_notification_sent = false;
    
    

     void OnEnable()
    {
        virus_windows = GameObject.Find("virus_windows");
        sound_manager = GameObject.Find("sound_manager");
    }

    void Start()
    {
        StartCoroutine(Instantiate_First_Pop_Up_Windows());

    }

    void Virus_Window_Instantiator()
    {
        
        if (Time.time >= next_pop_up_time)
        {
            int random_number = Random.Range(0, 4);
            switch(random_number)
            {
                case 0:
                    Instantiate(virus_window_1, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
                    sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
                    break;
                case 1:
                    Instantiate(virus_window_2, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
                    sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
                    break;
                case 2:
                    Instantiate(virus_window_3, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
                    sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
                    break;
                case 3:
                    Instantiate(virus_window_4, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
                    sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
                    break;
                case 4:
                    Instantiate(virus_window_5, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
                    sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
                    break;
            }
            
            next_pop_up_time = Time.time + pop_up_speed;
        }
    }

    void Pop_Up_Speed_Controller()
    {
        if(virus_windows.transform.childCount <= 2)
        {
            pop_up_speed = 0.7f;
        }

        else if(virus_windows.transform.childCount > 2 && virus_windows.transform.childCount < 7)
        {
            pop_up_speed = 1.2f;
        }

        else if (virus_windows.transform.childCount >= 7)
        {
            pop_up_speed = 2f;
        }
    }

    void Update()
    {
        
        Pop_Up_Speed_Controller();

        if(first_dialogue_box_closed)
        {
            if (virus_windows.transform.childCount > 0 && virus_windows.transform.childCount < 20)
            {
                Virus_Window_Instantiator();
            }

            if(virus_windows.transform.childCount == 0 && !tara_notification_sent)
            {
                tara_notification_sent = true;
                Invoke("Open_Tara_Notification2", 1f);
            }
        }

        
        
        //print(pop_up_speed);
        //print(GameObject.Find("virus_windows").transform.childCount);
    }

    IEnumerator Instantiate_First_Pop_Up_Windows()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(virus_window_1, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
        sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
        yield return new WaitForSeconds(0.7f);
        Instantiate(virus_window_2, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
        sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
        yield return new WaitForSeconds(0.7f);
        Instantiate(virus_window_3, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
        sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
        yield return new WaitForSeconds(0.7f);
        Instantiate(virus_window_4, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
        sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
        yield return new WaitForSeconds(0.7f);
        Instantiate(virus_window_5, new Vector3(Random.Range(300, 1500), Random.Range(350, 800), 0), Quaternion.identity, virus_windows.transform);
        sound_manager.GetComponent<sound_manager>().Play_Error_Sound();
        yield return new WaitForSeconds(1f);
        Open_Tara_Notification1();
    }

    void Open_Tara_Notification1()
    {
        tara_notification1.SetActive(true);
    }

    void Open_Tara_Notification2()
    {
        tara_notification2.SetActive(true);
    }


}
