export class ProductStoreRequest {
    constructor(
        public id: number,
        public productStoreId: number,
        public quantity: number,        
        public isCancelled: boolean        
    ) { }
}
