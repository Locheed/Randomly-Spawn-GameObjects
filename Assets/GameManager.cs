using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public List<GameObject> objectsCreated = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var coordX = Random.Range(-6, 6);
            var coordY = Random.Range(-6, 6);
            var selected = objects[Random.Range(0, objects.Count)];
            if (objectsCreated.Count < 10)
            {
            Instantiate(selected, new Vector3(coordX, coordY, 0), Quaternion.identity);
            objectsCreated.Add(selected);
            }
            if (objectsCreated.Count == 10)
            {
                foreach (var obj in objectsCreated)
                {
                    Renderer renderer;
                    renderer = obj.GetComponent<Renderer>();
                    renderer.sharedMaterial.SetColor("_Color", Color.green);
                }
                objectsCreated.Clear();
            }
        }
    }
}
