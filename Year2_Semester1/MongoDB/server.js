require('dotenv').config();
const express = require('express');
const cors = require('cors');
const connectDB = require('./connect');

const app = express();
const PORT = process.env.PORT || 3000;

app.use(cors());
app.use(express.json());

app.listen(PORT, async () => {
  try {
    await connectDB();
    console.log('Connected to MongoDB, running on port ' + PORT);
  } catch (err) {
    console.log('Failed to connect to MongoDB: ' + err.message);
    process.exit(1);
  }
});
