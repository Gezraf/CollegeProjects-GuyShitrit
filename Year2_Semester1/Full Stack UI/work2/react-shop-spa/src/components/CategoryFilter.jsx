import { useShop } from '../context/ShopContext';

const CATEGORIES = ['smartphones', 'laptops', 'fragrances', 'groceries'];

export default function CategoryFilter() {
  const { fetchProductsByCategory, activeFilter } = useShop();

  return (
    <div style={{ display: 'flex', gap: '8px', flexWrap: 'wrap', marginBottom: '16px' }}>
      {CATEGORIES.map((category) => {
        const isActive = activeFilter === category;
        return (
          <button
            key={category}
            onClick={() => fetchProductsByCategory(category)}
            style={{
              padding: '8px 14px',
              cursor: 'pointer',
              backgroundColor: isActive ? '#2563eb' : '#f1f5f9',
              color: isActive ? '#ffffff' : '#000000',
              border: '1px solid #ccc',
              borderRadius: '4px',
            }}
          >
            {category}
          </button>
        );
      })}
    </div>
  );
}
