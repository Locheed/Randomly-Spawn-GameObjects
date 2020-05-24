using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public List<GameObject> objectsCreated = new List<GameObject>();
    private bool _changeColor = false;
    public int SpawnCount { get; set; }

    // Start is called before the first frame update
    void Start()
    {
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if ( SpawnCount == 10)
            {
                _changeColor = true;
                return;
            }

            var coordX = Random.Range(-6, 6);
            var coordY = Random.Range(-6, 6);
            var selected = objects[Random.Range(0, objects.Count)];
            
            GameObject gameObject = Instantiate(selected, new Vector3(coordX, coordY, 0), Quaternion.identity) as GameObject;
            objectsCreated.Add(gameObject);
            SpawnCount++;
            
        }

        if (_changeColor == true)
        {
            _changeColor = false;
            foreach (var obj in objectsCreated)
            {
                    
                obj.GetComponent<MeshRenderer>().material.color = Color.red;
                   
            }
            objectsCreated.Clear();
        }
            
    }
}
