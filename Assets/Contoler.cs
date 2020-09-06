using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Card
{
    public string color;
    public string value;
    public GameObject go;

    public Card(string col, string val)
    {
        this.go = null;
        this.color = col;
        this.value = val;
    }
}

public class Player
{
    public string Name;
    public int[] chips;
}

public class Contoler : MonoBehaviour
{
    public GameObject colorCav;
    public GameObject valueCav;

    public Button resetBtn;
    public Button discardBtn;
    public Button stackBtn;
    public Button RivBtn1;
    public Button RivBtn2;
    public Button RivBtn3;
    public Button RivBtn4;
    public Button RivBtn5;

    public GameObject Riv1;
    public GameObject Riv2;
    public GameObject Riv3;
    public GameObject Riv4;
    public GameObject Riv5;

    public Card curPick = new Card(null,null);

    public Material cleanCard;

    public Material testCARD;

    public Text playerList;

    

    private Button[] tmpallChildernOfColor;
    private List<GameObject> allChildernOfColor = new List<GameObject>();
    private Button[] tmpallChildernOfValue;
    private List<GameObject> allChildernOfValue = new List<GameObject>();

    public string stringToEdit = "Hello World";


    public List<string> player = new List<string>();


    public List<Material> cardHerzMats = new List<Material>();
    public List<Material> cardKaroMats = new List<Material>();
    public List<Material> cardKreuzMats = new List<Material>();
    public List<Material> cardPikMats = new List<Material>();



    
    private TouchScreenKeyboard keyboard;


    // Start is called before the first frame update
    void Start()
    {
        keyboard = TouchScreenKeyboard.Open("test", TouchScreenKeyboardType.Default, false,false,false,false,"TEST",12);
        keyboard = TouchScreenKeyboard.Open("test", TouchScreenKeyboardType.NumberPad, false,false,false,false,"TEST",2);


        Debug.Log(keyboard.text);
        tmpallChildernOfColor = colorCav.GetComponentsInChildren<Button>();
        tmpallChildernOfValue = valueCav.GetComponentsInChildren<Button>();


        //erstmal eingeben wie viele spieler und dann die namen nacheinander


        foreach (Button child in tmpallChildernOfColor)
        {
            allChildernOfColor.Add(child.gameObject);
        }
        foreach (Button child in tmpallChildernOfValue)
        {
            allChildernOfValue.Add(child.gameObject);
        }

        foreach (GameObject child in allChildernOfColor)
        {
            //Debug.Log(child.name);
        }

        foreach (GameObject child in allChildernOfValue)
        {
            //Debug.Log(child.name);
        }




        RivBtn1.onClick.AddListener(delegate { picking(Riv1); });
        RivBtn2.onClick.AddListener(delegate { picking(Riv2); });
        RivBtn3.onClick.AddListener(delegate { picking(Riv3); });
        RivBtn4.onClick.AddListener(delegate { picking(Riv4); });
        RivBtn5.onClick.AddListener(delegate { picking(Riv5); });

        resetBtn.onClick.AddListener(reset);

        foreach (GameObject child in allChildernOfColor)
        {
            child.GetComponent<Button>().onClick.AddListener(delegate { colorChosen(child.name); });
        }
        foreach (GameObject child in allChildernOfValue)
        {
            child.GetComponent<Button>().onClick.AddListener(delegate { valueChosen(child.name); });
        }

    }

    public Material getMat(string col, string val)
    {
        if (col.Equals("Herz"))
        {
            if (val.Equals("A"))
            {
                return cardHerzMats[0];
            }
            else if (val.Equals("2"))
            {
                return cardHerzMats[1];
            }
            else if (val.Equals("3"))
            {
                return cardHerzMats[2];
            }
            else if (val.Equals("4"))
            {
                return cardHerzMats[3];
            }
            else if (val.Equals("5"))
            {
                return cardHerzMats[4];
            }
            else if (val.Equals("6"))
            {
                return cardHerzMats[5];
            }
            else if (val.Equals("7"))
            {
                return cardHerzMats[6];
            }
            else if (val.Equals("8"))
            {
                return cardHerzMats[7];
            }
            else if (val.Equals("9"))
            {
                return cardHerzMats[8];
            }
            else if (val.Equals("10"))
            {
                return cardHerzMats[9];
            }
            else if (val.Equals("J"))
            {
                return cardHerzMats[10];
            }
            else if (val.Equals("Q"))
            {
                return cardHerzMats[11];
            }
            else if (val.Equals("K"))
            {
                return cardHerzMats[12];
            }
            else
            {
                return null;
            }
        }
        else if (col.Equals("Karo"))
        {
            if (val.Equals("A"))
            {
                return cardKaroMats[0];
            }
            else if (val.Equals("2"))
            {
                return cardKaroMats[1];
            }
            else if (val.Equals("3"))
            {
                return cardKaroMats[2];
            }
            else if (val.Equals("4"))
            {
                return cardKaroMats[3];
            }
            else if (val.Equals("5"))
            {
                return cardKaroMats[4];
            }
            else if (val.Equals("6"))
            {
                return cardKaroMats[5];
            }
            else if (val.Equals("7"))
            {
                return cardKaroMats[6];
            }
            else if (val.Equals("8"))
            {
                return cardKaroMats[7];
            }
            else if (val.Equals("9"))
            {
                return cardKaroMats[8];
            }
            else if (val.Equals("10"))
            {
                return cardKaroMats[9];
            }
            else if (val.Equals("J"))
            {
                return cardKaroMats[10];
            }
            else if (val.Equals("Q"))
            {
                return cardKaroMats[11];
            }
            else if (val.Equals("K"))
            {
                return cardKaroMats[12];
            }
            else
            {
                return null;
            }
        }
        else if (col.Equals("Kreuz"))
        {
            if (val.Equals("A"))
            {
                return cardKreuzMats[0];
            }
            else if (val.Equals("2"))
            {
                return cardKreuzMats[1];
            }
            else if (val.Equals("3"))
            {
                return cardKreuzMats[2];
            }
            else if (val.Equals("4"))
            {
                return cardKreuzMats[3];
            }
            else if (val.Equals("5"))
            {
                return cardKreuzMats[4];
            }
            else if (val.Equals("6"))
            {
                return cardKreuzMats[5];
            }
            else if (val.Equals("7"))
            {
                return cardKreuzMats[6];
            }
            else if (val.Equals("8"))
            {
                return cardKreuzMats[7];
            }
            else if (val.Equals("9"))
            {
                return cardKreuzMats[8];
            }
            else if (val.Equals("10"))
            {
                return cardKreuzMats[9];
            }
            else if (val.Equals("J"))
            {
                return cardKreuzMats[10];
            }
            else if (val.Equals("Q"))
            {
                return cardKreuzMats[11];
            }
            else if (val.Equals("K"))
            {
                return cardKreuzMats[12];
            }
            else
            {
                return null;
            }
        }
        else if (col.Equals("Pik"))
        {
            if (val.Equals("A"))
            {
                return cardPikMats[0];
            }
            else if (val.Equals("2"))
            {
                return cardPikMats[1];
            }
            else if (val.Equals("3"))
            {
                return cardPikMats[2];
            }
            else if (val.Equals("4"))
            {
                return cardPikMats[3];
            }
            else if (val.Equals("5"))
            {
                return cardPikMats[4];
            }
            else if (val.Equals("6"))
            {
                return cardPikMats[5];
            }
            else if (val.Equals("7"))
            {
                return cardPikMats[6];
            }
            else if (val.Equals("8"))
            {
                return cardPikMats[7];
            }
            else if (val.Equals("9"))
            {
                return cardPikMats[8];
            }
            else if (val.Equals("10"))
            {
                return cardPikMats[9];
            }
            else if (val.Equals("J"))
            {
                return cardPikMats[10];
            }
            else if (val.Equals("Q"))
            {
                return cardPikMats[11];
            }
            else if (val.Equals("K"))
            {
                return cardPikMats[12];
            }
            else
            {
                return null;
            }
        }


        return null;
    }

   

    void picking(GameObject clickedBtn)
    {
        curPick.go = clickedBtn;
        colorCav.SetActive(true);
        valueCav.SetActive(false);
        Debug.Log("Bitte Farbe Wählen!");
    }

    void colorChosen(string name)
    {
        colorCav.SetActive(false);
        Debug.Log(name);
        curPick.color = name;
        valueCav.SetActive(true);
    }

    void valueChosen(string name)
    {
        valueCav.SetActive(false);
        Debug.Log(name);
        curPick.value = name;
        //Lade Karte auf Feld
        Debug.Log(curPick.color + curPick.value);
        Material[] mats = curPick.go.GetComponent<Renderer>().materials;
        mats[0] = getMat(curPick.color, curPick.value);
        curPick.go.GetComponent<Renderer>().materials = mats;
    }

    void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
