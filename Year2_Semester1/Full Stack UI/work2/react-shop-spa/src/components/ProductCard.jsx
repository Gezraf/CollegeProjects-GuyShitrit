export default function ProductCard({ product }) {
  return (
    <div style={{ border: '1px solid #ddd', borderRadius: '6px', padding: '12px', display: 'flex', flexDirection: 'column', gap: '6px' }}>
      <img
        src={product.thumbnail}
        alt={product.title}
        style={{ width: '100%', height: '160px', objectFit: 'cover', borderRadius: '4px' }}
      />
      <h3 style={{ margin: '4px 0', fontSize: '16px' }}>{product.title}</h3>
      <p style={{ margin: 0, fontSize: '14px', color: '#555' }}>Category: {product.category}</p>
      <p style={{ margin: 0, fontSize: '15px', fontWeight: 'bold' }}>Price: ${product.price}</p>
      <p style={{ margin: 0, fontSize: '14px' }}>Rating: {product.rating}</p>
    </div>
  );
}
