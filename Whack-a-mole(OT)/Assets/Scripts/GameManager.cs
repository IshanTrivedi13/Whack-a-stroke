using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<groundhog> hogs;
    private HashSet<groundhog> currentHogs = new HashSet<groundhog>();
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
        if (currentHogs.Count <= (0.5)) 
        {
            // Choose a random hog.
            int index = Random.Range(0, hogs.Count);
            if (!currentHogs.Contains(hogs[index])) 
            {
                currentHogs.Add(hogs[index]);
                hogs[index].Activate();
            }
        }
    }
    public void Whacked(int hogIndex) 
    {
        Debug.Log("");
        currentHogs.Remove(hogs[hogIndex]);
    }
    public void Missed(int hogIndex) 
    {
        currentHogs.Remove(hogs[hogIndex]);
    }
}
