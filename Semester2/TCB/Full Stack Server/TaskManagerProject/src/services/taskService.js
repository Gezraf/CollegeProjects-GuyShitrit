/*
שאלת הבנה:

Expressהיא כדי שהקוד לא יהיה תלוי ב Serviceהסיבה שמפרידים את הלוגיקה העסקית לשכבת ה
Controllerנצטרך לשנות רק את ה Nest.js או Fastify אחר כמו Frameworkככה שאם נרצה מתישהו בעתיד לעבור ל
והלוגיקה עצמה תישאר בדיוק אותו דבר

לבד Serviceבנוסף זה גם הופך בדיקות לקלות יותר כי אז אפשר פשוט לבדוק את הפונקציות של ה 
resו reqבלי להרים שרת ובלי להשתמש ב 
*/

let tasks = [];

const createValidationError = (message) => {
  const error = new Error(message);
  error.status = 400;
  return error;
};


const getAllTasks = async () => {
  return tasks;
};


const createTask = async (taskData) => {
  const { title, userId } = taskData;

  if (typeof title !== "string" || title.trim().length < 3) {
    throw createValidationError("Title must be a string with at least 3 characters");
  }

  if (typeof userId !== "string" || userId.trim().length === 0) {
    throw createValidationError("Owner id is required");
  }

  const exists = tasks.some(
    (task) =>
      task.title.toLowerCase() === title.trim().toLowerCase() &&
      task.userId === userId
  );

  if (exists) {
    throw createValidationError("Task already exists for this owner");
  }

  const newTask = {
    id: Date.now().toString(),
    userId: userId.trim(),
    title: title.trim(),
    completed: false,
    createdAt: new Date()
  };

  tasks.push(newTask);

  return newTask;
};


const updateTask = async (id, taskData) => {
  const { title, completed } = taskData;

  if (typeof id !== "string" || id.trim().length === 0) {
    throw createValidationError("Task id is required");
  }

  const task = tasks.find((task) => task.id === id);

  if (!task) {
    throw createValidationError("Task not found");
  }

  if (title !== undefined) {
    if (typeof title !== "string" || title.trim().length < 3) {
      throw createValidationError("Title must be a string with at least 3 characters");
    }

    task.title = title.trim();
  }

  if (completed !== undefined) {
    if (typeof completed !== "boolean") {
      throw createValidationError("Completed must be true or false");
    }

    task.completed = completed;
  }

  task.updatedAt = new Date();

  return task;
};


const deleteTask = async (id) => {
  if (typeof id !== "string" || id.trim().length === 0) {
    throw createValidationError("Task id is required");
  }

  const taskExists = tasks.some((task) => task.id === id);

  if (!taskExists) {
    throw createValidationError("Task not found");
  }

  tasks = tasks.filter((task) => task.id !== id);

  return true;
};

export default { getAllTasks, createTask, updateTask, deleteTask };