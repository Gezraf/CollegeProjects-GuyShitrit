import { ShopProvider } from './context/ShopContext';
import Header from './components/Header';
import CategoryFilter from './components/CategoryFilter';
import ProductList from './components/ProductList';
import Pagination from './components/Pagination';

export default function App() {
  return (
    <ShopProvider>
      <div style={{ maxWidth: '1100px', margin: '0 auto', padding: '16px', fontFamily: 'sans-serif' }}>
        <Header />
        <CategoryFilter />
        <ProductList />
        <Pagination />
      </div>
    </ShopProvider>
  );
}
