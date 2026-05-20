import taskService from "../services/taskService.js";

export const getTasks = async (req, res) => {
  try {
    const tasks = await taskService.getAllTasks();
    res.status(200).json(tasks);
  } catch (error) {
    console.error("Error getting tasks:", error);
    res.status(500).json({ message: "Internal Server Error" });
  }
};


export const createTask = async (req, res) => { // POST /tasks/:userId
  try {
    const { title } = req.body;
    const { userId } = req.params;

    const newTask = await taskService.createTask({
      title,
      userId
    });

    res.status(201).json(newTask);
  } catch (error) {
    console.error("Error creating task:", error);

    if (error.status === 400) {
      return res.status(400).json({ message: error.message });
    }

    res.status(500).json({ message: "Internal Server Error" });
  }
};


export const updateTask = async (req, res) => { // PUT /tasks/:id
  try {
    const { id } = req.params;
    const { title, completed } = req.body;

    const updatedTask = await taskService.updateTask(id, {
      title,
      completed
    });

    res.status(200).json(updatedTask);
  } catch (error) {
    console.error("Error updating task:", error);

    if (error.status === 400) {
      return res.status(400).json({ message: error.message });
    }

    res.status(500).json({ message: "Internal Server Error" });
  }
};


export const deleteTask = async (req, res) => { // DELETE /tasks/:id
  try {
    const { id } = req.params;

    await taskService.deleteTask(id);

    res.status(204).send();
  } catch (error) {
    console.error("Error deleting task:", error);

    if (error.status === 400) {
      return res.status(400).json({ message: error.message });
    }

    res.status(500).json({ message: "Internal Server Error" });
  }
};