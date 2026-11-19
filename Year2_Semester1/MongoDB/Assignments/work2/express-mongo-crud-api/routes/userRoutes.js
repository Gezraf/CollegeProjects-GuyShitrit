const express = require('express');
const {
  getAllUsers,
  getUserById,
  createUser,
  updateUser,
  deleteUser,
  deleteAllUsers,
} = require('../controllers/userController');

const router = express.Router();

router.get('/', getAllUsers);
router.get('/:idNumber', getUserById);
router.post('/', createUser);
router.put('/:idNumber', updateUser);
router.delete('/:idNumber', deleteUser);
router.delete('/', deleteAllUsers);

module.exports = router;
