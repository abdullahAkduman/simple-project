using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public Text scoreTxt;
    float score;

    public void Buttons(int i){
        if(i == 0){ 
            ChangeScore(1);
        }
        if(i == 1){
            if(score > 5 || score == 5){
                ChangeScore(2);
            }
        }
        if(i == 2){
            if(score > 15 || score == 15){
                ChangeScore(3);
            }
        }
        if(i == 3){
            if(score > 30 || score == 30){
                ChangeScore(4);
            }
        }
    }

    void ChangeScore(float f){
        score += f;
        scoreTxt.text = score.ToString();
    }
}
