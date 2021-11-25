using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public string playerName;
    public string maxPlayerName ="";
    public int maxPoints;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Serializable]
    class SaveData
    {
        public int maxPoints;
        public string maxPlayerName;
    }

    public void SavePlayerData()
    {
        SaveData data = new SaveData();
        data.maxPoints = maxPoints;
        data.maxPlayerName = ScoreManager.Instance.maxPlayerName;

        string json = JsonUtility.ToJson(data);
        Debug.Log(Application.persistentDataPath + "/savefile.json");
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            maxPoints = data.maxPoints;
            maxPlayerName = data.maxPlayerName;
        }

    }
}
