function Profile({ user, onRemove }) {
  const initial = user.fullName.trim().charAt(0).toUpperCase();

  return (
    <article className="profile-card">
      <div className="avatar">{initial}</div>
      <div className="profile-info">
        <h3>{user.fullName}</h3>
        <p>
          <strong>אימייל:</strong> {user.email}
        </p>
        <p>
          <strong>גיל:</strong> {user.age}
        </p>
        <p>
          <strong>ת.ז.:</strong> {user.idNumber}
        </p>
      </div>
      <button type="button" className="remove-btn" onClick={() => onRemove(user.id)}>
        הסר
      </button>
    </article>
  );
}

export default Profile;
