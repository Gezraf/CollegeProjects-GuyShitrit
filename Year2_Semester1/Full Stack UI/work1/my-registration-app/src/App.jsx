import RegistrationForm from './components/RegistrationForm.jsx';
import Profile from './components/Profile.jsx';
import useUsers from './hooks/useUsers.js';

function App() {
  const { users, addUser, removeUser } = useUsers();

  return (
    <main className="app">
      <RegistrationForm onRegister={addUser} />

      <section className="users-section">
        <h2>משתמשים רשומים ({users.length})</h2>
        {users.length === 0 ? (
          <p className="empty">עדיין לא נרשמו משתמשים</p>
        ) : (
          <div className="users-list">
            {users.map((user) => (
              <Profile key={user.id} user={user} onRemove={removeUser} />
            ))}
          </div>
        )}
      </section>
    </main>
  );
}

export default App;
