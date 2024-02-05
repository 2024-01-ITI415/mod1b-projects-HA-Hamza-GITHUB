using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]               
    public GameObject       basketPrefab;
    public int              numBaskets = 3;
    public float            basketBottomY = -14;
    public float            basketSpacingY = 2f;
    public List<GameObject> basketList;

    
    void Start () {
        basketList = new List<GameObject>();
        for (int i=0; i<numBaskets; i++) {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + basketSpacingY;
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);  
        }
    }
    
    public void AppleDestroyed() {             
        // Destroy all of the falling apples
        GameObject[] tAppleArray=GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray) {
            Destroy(tGO);
        }
        
        // Destroy one of the baskets          
        // Get the index of the last Basket in 
        int basketIndex = basketList.Count-1;
        // Get a reference to that Basket GameO
        GameObject tBasketGO = basketList[basketIndex];
        // Remove the Basket from the list and 
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        // If there are no Baskets left, restar
        if (basketList.Count == 0) {
            SceneManager.LoadScene("Main-ApplePicker");
        }


    }
}
