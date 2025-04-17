using System;

[System.Serializable]
public class Task
{
    public string id;
    public string description;
    public bool iscollider;
    public bool isCompleted;
    public string targetLocationID; // 新增：目标地点ID
    
    public Task(string id, string description)
    {
        this.id = id;
        this.description = description;
        this.isCompleted = false;
    }
}