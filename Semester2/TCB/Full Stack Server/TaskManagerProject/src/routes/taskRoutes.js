import { Router } from "express";
import {
  getTasks,
  createTask,
  updateTask,
  deleteTask
} from "../controllers/taskController.js";


const router = Router();


router.get("/", getTasks);
router.post("/:userId", createTask);
router.put("/:id", updateTask);
router.delete("/:id", deleteTask);

export default router;