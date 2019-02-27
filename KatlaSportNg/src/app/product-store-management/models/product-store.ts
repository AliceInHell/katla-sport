import { Product } from './product'

export class ProductStoreItem {
    constructor(
        public id: number,
        public quantity: number,
        public product: Product
    ) { }
}
