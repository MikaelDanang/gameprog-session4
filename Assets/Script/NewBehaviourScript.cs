using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
        public void ChangeMyScene(string namaScene)
        {
            SceneManager.LoadScene(namaScene);
        }
    }

    // Update is called once per frame
 //  void Update()
   // {
        
   // }
//}
