using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeArm : MonoBehaviour
{
    // Start is called before the first frame update
    public void btn_changes_scenes(string scene_name){
        SceneManager.LoadScene(scene_name);
    }
}
