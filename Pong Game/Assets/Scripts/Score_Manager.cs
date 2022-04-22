using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    [SerializeField] private Text PlayerText;
    [SerializeField] private Text AIpaddleText;

    private int Ai_paddle_score;
    private int player_score;
    // Start is called before the first frame update
    
    public void UpdatePlayerSCore()
    {
        player_score++;
        PlayerText.text = player_score.ToString();
    }

    public void UpdateAISCore()
    {
        Ai_paddle_score++;
        AIpaddleText.text = Ai_paddle_score.ToString();
    }
}
