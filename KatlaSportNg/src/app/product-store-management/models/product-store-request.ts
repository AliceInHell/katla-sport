export class ProductStoreRequest {
    constructor(
        public id: number,
        public productStoreId: number,
        public hiveId: number,
        public hiveSectionId: number,
        public quantity: number,        
        public isProcessed: boolean        
    ) { }
}
