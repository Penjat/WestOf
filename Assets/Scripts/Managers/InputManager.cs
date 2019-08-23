using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour{

    void Update(){
      if (Input.GetMouseButtonDown(0)){
        TouchBegan();
      }
      if (Input.GetMouseButtonUp(0)){
        TouchEnded();
      }
    }

    private void TouchBegan(){
      Debug.Log("touch began");
    }
    private void TouchMoved(){
      Debug.Log("touch moved");
    }
    private void TouchEnded(){
      Debug.Log("touch ended");
    }
}
