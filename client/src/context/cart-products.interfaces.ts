export interface Product {
    id: number
    description: string
    price: string
    status: boolean
    detail: string
    image: string
}

export interface ProductsCartStore {
    setProducts: (products: Product[]) => void;
    products: Product[],
}