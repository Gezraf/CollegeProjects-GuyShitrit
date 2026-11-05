import { useState } from 'react';

export default function useUsers() {
  const [users, setUsers] = useState([]);

  const addUser = (user) => {
    // מערך חדש, בלי לשנות את הקיים
    setUsers((prev) => [...prev, { ...user, id: Date.now() }]);
  };

  const removeUser = (id) => {
    setUsers((prev) => prev.filter((user) => user.id !== id));
  };

  return { users, addUser, removeUser };
}
