const User = require('../models/User');

const handleError = (err, res) => {
  if (err.name === 'ValidationError') {
    const errors = Object.values(err.errors).map((e) => e.message);
    return res.status(400).json({ message: 'Validation failed', errors });
  }
  if (err.code === 11000) {
    const field = Object.keys(err.keyPattern)[0];
    return res.status(409).json({ message: `${field} already exists` });
  }
  res.status(500).json({ message: 'Server error' });
};

const getAllUsers = async (req, res) => {
  try {
    const users = await User.find();
    res.status(200).json({ count: users.length, users });
  } catch (err) {
    handleError(err, res);
  }
};

const getUserById = async (req, res) => {
  try {
    const user = await User.findOne({ idNumber: req.params.idNumber });
    if (!user) return res.status(404).json({ message: 'User not found' });
    res.status(200).json(user);
  } catch (err) {
    handleError(err, res);
  }
};

const createUser = async (req, res) => {
  try {
    const { idNumber, fullName, email, phone, birthDate, password } = req.body;
    const user = await User.create({ idNumber, fullName, email, phone, birthDate, password });
    res.status(201).json({ message: 'User created', user });
  } catch (err) {
    handleError(err, res);
  }
};

const updateUser = async (req, res) => {
  try {
    const { fullName, email, phone, birthDate, password } = req.body;
    const user = await User.findOneAndUpdate(
      { idNumber: req.params.idNumber },
      { fullName, email, phone, birthDate, password },
      { new: true, runValidators: true }
    );
    if (!user) return res.status(404).json({ message: 'User not found' });
    res.status(200).json(user);
  } catch (err) {
    handleError(err, res);
  }
};

const deleteUser = async (req, res) => {
  try {
    const user = await User.findOneAndDelete({ idNumber: req.params.idNumber });
    if (!user) return res.status(404).json({ message: 'User not found' });
    res.status(200).json({ message: 'User deleted' });
  } catch (err) {
    handleError(err, res);
  }
};

const deleteAllUsers = async (req, res) => {
  try {
    const result = await User.deleteMany({});
    res.status(200).json({ message: 'All users deleted', deletedCount: result.deletedCount });
  } catch (err) {
    handleError(err, res);
  }
};

module.exports = { getAllUsers, getUserById, createUser, updateUser, deleteUser, deleteAllUsers };
