export class ProductStoreRequest {
    constructor(
        public id: number,
        public productStoreId: number,
        public time: string,
        public isCancelled: boolean        
    ) { }
}
