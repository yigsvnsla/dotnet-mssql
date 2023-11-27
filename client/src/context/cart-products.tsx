import { create } from 'zustand'
import { ProductsCartStore } from './cart-products.interfaces'

export const useProductCartCtx = create<ProductsCartStore>((set, get) => ({
    products: [],
    get getSoldOuts() {
        return get().products.filter(item => !!item.SoldOut)
    },
    setProducts: (products) => set((currentState) => ({ products: [...currentState.products, ...products] }))
}))