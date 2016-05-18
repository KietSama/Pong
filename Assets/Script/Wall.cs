using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Wall : MonoBehaviour {

    public Text playerPoint;
    public GameObject ball;
    int point = 0;
    public GameObject player;
    public GameObject respawnPoint;

    Transform posPlayer;

    void Start()
    {
        PrintPoint();

        posPlayer = player.GetComponent<Transform>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        point++;
        PrintPoint();

        Destroy(col.gameObject);

        wait();

        GameObject go = (GameObject) Instantiate(ball, respawnPoint.GetComponent<Transform>().position, Quaternion.identity);
    }

    void PrintPoint()
    {
        if(playerPoint.name == "ScorePlayer1")
            playerPoint.text = "Player 1: " + point;
        if (playerPoint.name == "ScorePlayer2")
            playerPoint.text = "Player 2: " + point;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
    }

}
