using UnityEngine;
using TMPro;

public class DamageNumber : MonoBehaviour
{
    public static DamageNumber current;
    public GameObject prefab; 

    public void Awake()
    {
        current = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)){
            CreatePopUp(Vector3.one, Random.Range(0, 1000).ToString());
        }
    }

    public void CreatePopUp(Vector3 position, string text){

        var popup = Instantiate(prefab, position, Quaternion.identity);
        var temp = popup.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        temp.text = text;

        Destroy(popup, 1f);
    }
}
