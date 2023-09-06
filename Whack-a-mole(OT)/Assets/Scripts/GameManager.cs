using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Alien> hogs;

    private HashSet<Alien> currentHogs = new HashSet<Alien>();
    int prevIndex = 0;

    // Add timer variables
    private float timer = 30f;
    private bool isGameActive = true;

    private void Start()
    {
        // Hide all the visible hogs.
        for (int i = 0; i < hogs.Count; i++)
        {
            hogs[i].Hide();
            hogs[i].SetIndex(i);
        }
        // Remove any old game state.
        currentHogs.Clear();
    }

    public void Update()
    {
        if (isGameActive)
        {
            // Update the timer
            timer -= Time.deltaTime;

            // Check if the timer has reached 0
            if (timer <= 0f)
            {
                // Game over logic here
                isGameActive = false;
                Debug.Log("Game Over");
            }

            if (currentHogs.Count <= 0.5)
            {
                // Choose a random hog.
                int index = Random.Range(0, hogs.Count);
                if (!currentHogs.Contains(hogs[index]) && hogs[index] != hogs[prevIndex])
                {
                    currentHogs.Add(hogs[index]);
                    hogs[index].Activate();
                    prevIndex = index;
                }
            }
        }
    }

    public void Whacked(int hogIndex)
    {
        currentHogs.Remove(hogs[hogIndex]);
    }

    public void Missed(int hogIndex)
    {
        currentHogs.Remove(hogs[hogIndex]);
    }
}