using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject[] elements;
    [SerializeField]
    GameObject cell1, cell2, cell3;
    [SerializeField]
    Text FindElement;
    string WinnerName;
    public int WinnerInFirstLvl;

    GameObject Cell1;
    GameObject Cell2;
    GameObject Cell3;
    GameObject Cell4;
    GameObject Cell5;
    GameObject Cell6;
    GameObject Cell7;
    GameObject Cell8;
    GameObject Cell9;

    public Animation error;

    public GameObject WinPanel;

    public GameObject[] SellSpawnerPoints;
    public GameObject Cell;

    public bool lvl1 = true;
    public bool lvl2 = false;
    public bool lvl3 = false;


    public void Awake()
    {
 
        Spawner(); 
    }

    public void Spawner()
    {    
        GameObject element1 = elements[Random.Range(0, elements.Length)];
        GameObject element2 = elements[Random.Range(0, elements.Length)];
        GameObject element3 = elements[Random.Range(0, elements.Length)];
        GameObject element4 = elements[Random.Range(0, elements.Length)];
        GameObject element5 = elements[Random.Range(0, elements.Length)];
        GameObject element6 = elements[Random.Range(0, elements.Length)];
        GameObject element7 = elements[Random.Range(0, elements.Length)];
        GameObject element8 = elements[Random.Range(0, elements.Length)];
        GameObject element9 = elements[Random.Range(0, elements.Length)];


        if (element1 == element2 || element1 == element3 || element1 == element4 || element1 == element5 || element1 == element6 || element1 == element7 || element1 == element8 || element1 == element9)
            element1 = elements[Random.Range(0, elements.Length)];
        if (element2 == element3 || element2 == element4 || element2 == element5 || element2 == element6 || element2 == element7 || element1 == element8 || element1 == element9 || element2 == element1)
            element2 = elements[Random.Range(0, elements.Length)];
        if (element3 == element4 || element3 == element5 || element3 == element6 || element3 == element7 || element3 == element8 || element3 == element9 || element3 == element2 || element3 == element1)
            element3 = elements[Random.Range(0, elements.Length)];
        if (element4 == element5 || element4 == element6 || element4 == element7 || element4 == element8 || element4 == element9 || element4 == element3 || element4 == element2 || element4 == element1)
            element4 = elements[Random.Range(0, elements.Length)];
        if (element5 == element6 || element5 == element7 || element5 == element8 || element5 == element9 || element5 == element4 || element5 == element3 || element5 == element2 || element5 == element1)
            element5 = elements[Random.Range(0, elements.Length)];
        if (element6 == element7 || element6 == element8 || element6 == element9 || element6 == element5 || element6 == element4 || element6 == element3 || element6 == element2 || element6 == element1)
            element6 = elements[Random.Range(0, elements.Length)];
        if (element7 == element8 || element7 == element9 || element7 == element6 || element7 == element5 || element7 == element4 || element7 == element3 || element7 == element2 || element7 == element1)
            element7 = elements[Random.Range(0, elements.Length)];
        if (element8 == element9 || element8 == element7 || element8 == element6 || element8 == element5 || element8 == element4 || element8 == element3 || element8 == element2 || element8 == element1)
            element8 = elements[Random.Range(0, elements.Length)];

        Cell1 = Instantiate(element1, new Vector3(cell1.transform.position.x, cell1.transform.position.y, -2f), Quaternion.identity);
        Cell1.tag = "1";
        Cell2 = Instantiate(element2, new Vector3(cell2.transform.position.x, cell2.transform.position.y, -2f), Quaternion.identity);
        Cell2.tag = "2";
        Cell3 = Instantiate(element3, new Vector3(cell3.transform.position.x, cell3.transform.position.y, -2f), Quaternion.identity);
        Cell3.tag = "3";
        if (lvl2)
        {
            Cell4 = Instantiate(element4, new Vector3(SellSpawnerPoints[0].transform.position.x, SellSpawnerPoints[0].transform.position.y, -2f), Quaternion.identity);
            Cell4.tag = "4";
            Cell5 = Instantiate(element5, new Vector3(SellSpawnerPoints[1].transform.position.x, SellSpawnerPoints[1].transform.position.y, -2f), Quaternion.identity);
            Cell5.tag = "5";
            Cell6 = Instantiate(element6, new Vector3(SellSpawnerPoints[2].transform.position.x, SellSpawnerPoints[2].transform.position.y, -2f), Quaternion.identity);
            Cell6.tag = "6";    
        }
        if (lvl3)
        {
            Cell7 = Instantiate(element7, new Vector3(SellSpawnerPoints[3].transform.position.x, SellSpawnerPoints[3].transform.position.y, -2f), Quaternion.identity);
            Cell7.tag = "7";
            Cell8 = Instantiate(element8, new Vector3(SellSpawnerPoints[4].transform.position.x, SellSpawnerPoints[4].transform.position.y, -2f), Quaternion.identity);
            Cell8.tag = "8";
            Cell9 = Instantiate(element9, new Vector3(SellSpawnerPoints[5].transform.position.x, SellSpawnerPoints[5].transform.position.y, -2f), Quaternion.identity);
            Cell9.tag = "9";
        }
        if (lvl1)
        {
            WinnerInFirstLvl = Random.Range(1, 4);
            if (WinnerInFirstLvl == 1)
                WinnerName = element1.name;
            if (WinnerInFirstLvl == 2)
                WinnerName = element2.name;
            if (WinnerInFirstLvl == 3)
                WinnerName = element3.name;
        }
        if (lvl2)
        {
            WinnerInFirstLvl = Random.Range(1, 7);
            if (WinnerInFirstLvl == 1)
                WinnerName = element1.name;
            if (WinnerInFirstLvl == 2)
                WinnerName = element2.name;
            if (WinnerInFirstLvl == 3)
                WinnerName = element3.name;
            if (WinnerInFirstLvl == 4)
                WinnerName = element4.name;
            if (WinnerInFirstLvl == 5)
                WinnerName = element5.name;
            if (WinnerInFirstLvl == 6)
                WinnerName = element6.name;
        }
        if (lvl3)
        {
            WinnerInFirstLvl = Random.Range(1, 10);
            if (WinnerInFirstLvl == 1)
                WinnerName = element1.name;
            if (WinnerInFirstLvl == 2)
                WinnerName = element2.name;
            if (WinnerInFirstLvl == 3)
                WinnerName = element3.name;
            if (WinnerInFirstLvl == 4)
                WinnerName = element4.name;
            if (WinnerInFirstLvl == 5)
                WinnerName = element5.name;
            if (WinnerInFirstLvl == 6)
                WinnerName = element6.name;
            if (WinnerInFirstLvl == 7)
                WinnerName = element7.name;
            if (WinnerInFirstLvl == 8)
                WinnerName = element8.name;
            if (WinnerInFirstLvl == 9)
                WinnerName = element9.name;
        }
        FindElement.text = WinnerName;
    }
    private void Update()
    {
        Raycast();
    }

    public void Raycast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == WinnerInFirstLvl.ToString() && lvl1)
                {
                    Leve2();
                    print("WinLvl1");

                }
                else if (hit.collider.gameObject.tag == WinnerInFirstLvl.ToString() && lvl2)
                {
                    Level3();
                    print("WinLvl2");
                    lvl2 = false;
                    lvl3 = true;
                }
                else if (hit.collider.gameObject.tag == WinnerInFirstLvl.ToString() && lvl3)
                {
                    Win();
                }
                else
                    hit.collider.gameObject.GetComponent<Animation>().Play("LoseError");
                    print("Lose");
            }
        }
    }
    public void Leve2()
    {
        lvl1 = false;
        lvl2 = true; 

        Destroy(Cell1);
        Destroy(Cell2);
        Destroy(Cell3);

        Spawner();
        if (!lvl3)
        {
            Instantiate(Cell, new Vector3(SellSpawnerPoints[0].transform.position.x, SellSpawnerPoints[0].transform.position.y, 0f), Quaternion.identity);
            Instantiate(Cell, new Vector3(SellSpawnerPoints[1].transform.position.x, SellSpawnerPoints[1].transform.position.y, 0f), Quaternion.identity);
            Instantiate(Cell, new Vector3(SellSpawnerPoints[2].transform.position.x, SellSpawnerPoints[2].transform.position.y, 0f), Quaternion.identity);
        }
        
    }

    public void Level3()
    {
        lvl3 = true;
        

        Destroy(Cell4);
        Destroy(Cell5);
        Destroy(Cell6);

        Leve2();

        Instantiate(Cell, new Vector3(SellSpawnerPoints[3].transform.position.x, SellSpawnerPoints[3].transform.position.y, 0f), Quaternion.identity);
        Instantiate(Cell, new Vector3(SellSpawnerPoints[4].transform.position.x, SellSpawnerPoints[4].transform.position.y, 0f), Quaternion.identity);
        Instantiate(Cell, new Vector3(SellSpawnerPoints[5].transform.position.x, SellSpawnerPoints[5].transform.position.y, 0f), Quaternion.identity);
    }

    public void Win()
    {
        WinPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
