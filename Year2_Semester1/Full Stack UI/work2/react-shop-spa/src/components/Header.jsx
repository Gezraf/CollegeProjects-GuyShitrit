import { useShop } from '../context/ShopContext';

export default function Header() {
  const { fetchAllProducts, activeFilter } = useShop();

  return (
    <header style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', padding: '16px 0', borderBottom: '1px solid #ccc', marginBottom: '16px' }}>
      <h1 style={{ margin: 0, fontSize: '24px' }}>Online Shop</h1>
      <button
        onClick={fetchAllProducts}
        style={{
          padding: '8px 16px',
          cursor: 'pointer',
          backgroundColor: activeFilter === 'all' ? '#2563eb' : '#f1f5f9',
          color: activeFilter === 'all' ? '#ffffff' : '#000000',
          border: '1px solid #ccc',
          borderRadius: '4px',
        }}
      >
        All Products (limit=0)
      </button>
    </header>
  );
}
