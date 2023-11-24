using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour{

    private void Awake() {
        DemoTrigger.ResetList();    
    }

    public void ButtonClick(){
        DemoTrigger.TriggerArticleDownload();
    }


}
