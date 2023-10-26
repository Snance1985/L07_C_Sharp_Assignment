class Task{
    private string taskName;
    private bool taskComplete;
    private string taskDuration;

    public string TaskName
    {
        get { return taskName; }
    }

    public bool TaskComplete
    {
        get { return taskComplete; }
    }

    public string TaskDuration
    {
        get { return taskDuration; }
    }

    public Task(string name, string duration)
    {
        taskName = name;
        taskDuration = duration;
        taskComplete = false;
    }

    public bool IsComplete()
    {
        return taskComplete;
    }

    public string GetTaskName()
    {
        return taskName;
    }

    public string GetDuration()
    {
        return taskDuration;
    }

    public void SetComplete()
    {
        taskComplete = true;
    }

    public void SetTaskName(string name)
    {
        taskName = name;
    }

    public void SetDuration(string duration)
    {
        taskDuration = duration;
    }
}