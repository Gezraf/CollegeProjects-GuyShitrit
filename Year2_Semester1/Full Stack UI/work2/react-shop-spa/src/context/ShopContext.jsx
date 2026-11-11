import { createContext, useContext, useState, useEffect } from 'react';

const ShopContext = createContext();

export function ShopProvider({ children }) {
  const [products, setProducts] = useState([]);
  const [currentPage, setCurrentPage] = useState(1);
  const [totalProducts, setTotalProducts] = useState(0);
  const [activeFilter, setActiveFilter] = useState('all');
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const fetchAllProducts = async () => {
    setLoading(true);
    setError(null);
    try {
      const response = await fetch('https://dummyjson.com/products?limit=0');
      if (!response.ok) {
        throw new Error('Failed to fetch products');
      }
      const data = await response.json();
      setProducts(data.products);
      setTotalProducts(data.total);
      setActiveFilter('all');
      setCurrentPage(1);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const fetchProductsByCategory = async (category) => {
    setLoading(true);
    setError(null);
    try {
      const response = await fetch(`https://dummyjson.com/products/category/${category}`);
      if (!response.ok) {
        throw new Error('Failed to fetch category products');
      }
      const data = await response.json();
      setProducts(data.products);
      setActiveFilter(category);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const fetchProductsByPage = async (pageNumber) => {
    setLoading(true);
    setError(null);
    try {
      const skip = (pageNumber - 1) * 10;
      const response = await fetch(`https://dummyjson.com/products?limit=10&skip=${skip}`);
      if (!response.ok) {
        throw new Error('Failed to fetch page');
      }
      const data = await response.json();
      setProducts(data.products);
      setTotalProducts(data.total);
      setCurrentPage(pageNumber);
      setActiveFilter('page');
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    fetchAllProducts();
  }, []);

  const value = {
    products,
    currentPage,
    totalProducts,
    activeFilter,
    loading,
    error,
    fetchAllProducts,
    fetchProductsByCategory,
    fetchProductsByPage,
  };

  return <ShopContext.Provider value={value}>{children}</ShopContext.Provider>;
}

export function useShop() {
  return useContext(ShopContext);
}
