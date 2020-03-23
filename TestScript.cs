using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         //deklaracja
        int a;
        int b;
        //inicjalizacja
        a = 10;
        b=20;
        Debug.Log(a);

        float fa=4.5f;
        fa=4;
        bool logiczna = true;
        string str="napis taki";
        Debug.Log(" fa: "+fa+" logiczna: "+logiczna+" str: "+str);

        Debug.Log(a/b);
        Debug.Log(a/fa);
        Debug.Log(Mathf.Sqrt(2));

        Koniunkcja();
        Alternatywa();
    }

    public void Alternatywa(){
    bool a=true, b=true, c=false, alt1,alt2,alt3;
    if(a || b){alt1=true;}else{alt1=false;}
    if(b || c){alt2=true;}else{alt2=false;}
    if(a || c){alt3=true;}else{alt3=false;}
    Debug.Log("Alternatywa: alt1: "+alt1+ " alt2: "+alt2+ " alt3: "+alt3);
	}
    
    public void Koniunkcja(){
    bool a=true, b=true, c=false, alt1,alt2,alt3;
    if(a && b){alt1=true;}else{alt1=false;}
    if(b && c){alt2=true;}else{alt2=false;}
    if(a && c){alt3=true;}else{alt3=false;}
    Debug.Log("Koniunkcja: alt1: "+alt1+ " alt2: "+alt2+ " alt3: "+alt3);
	}

    void Update()
    {
        
    }
}
