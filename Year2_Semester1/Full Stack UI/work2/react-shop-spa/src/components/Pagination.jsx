import { useShop } from '../context/ShopContext';

export default function Pagination() {
  const { currentPage, totalProducts, fetchProductsByPage } = useShop();
  const totalPages = Math.ceil(totalProducts / 10) || 1;

  return (
    <div style={{ display: 'flex', justifyContent: 'center', alignItems: 'center', gap: '16px', marginTop: '24px', padding: '12px 0' }}>
      <button
        onClick={() => fetchProductsByPage(currentPage - 1)}
        disabled={currentPage === 1}
        style={{ padding: '8px 16px', cursor: currentPage === 1 ? 'not-allowed' : 'pointer' }}
      >
        Previous
      </button>
      <span>
        Page {currentPage} of {totalPages}
      </span>
      <button
        onClick={() => fetchProductsByPage(currentPage + 1)}
        disabled={currentPage >= totalPages}
        style={{ padding: '8px 16px', cursor: currentPage >= totalPages ? 'not-allowed' : 'pointer' }}
      >
        Next
      </button>
    </div>
  );
}
