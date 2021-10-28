using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    List<int> currentCombo = new List<int>();
    private List<int> pswd = new List<int>() { 6, 5, 1 };

    public float ShakeDetectionThreshold;
    public float MinShakeInterval;

    private float sqrShakeDetectionThreshold;
    private float timeSinceLastShake;


    // Start is called before the first frame update
    void Start()
    {
        currentCombo.Clear();
        sqrShakeDetectionThreshold = Mathf.Pow(ShakeDetectionThreshold, 2);
    }

    void Update() 
    {
        // Detection for shaking, i.e. passes threshold
        if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold
        && Time.unscaledTime >= timeSinceLastShake + MinShakeInterval)
        {
            timeSinceLastShake = Time.unscaledTime;
            if (CheckPassword())UnlockPhone();
            else RestartScene();
        }
    }

    // Add ingredient id to current combination
    public void AddToCombo(int id)
    {
        currentCombo.Add(id);
    }


    // Check Password
    bool CheckPassword ()
    {
        if (currentCombo.Count == pswd.Count)
        {
            for (int i = 0; i < currentCombo.Count; i++)
            {
                if (currentCombo[i] != pswd[i])
                {
                    return false;
                }
            }

            // Password was correct!
            return true;
        }
        else return false;
    }

    void UnlockPhone()
    {
        Debug.Log("PHONE UNLOCKED!");
        SceneManager.LoadScene("Unlocked_scene");
    }

    void RestartScene()
    {
        Debug.Log("PASSWORD INCORRECT!");
        SceneManager.LoadScene("Cocktail_scene");
    }
}
