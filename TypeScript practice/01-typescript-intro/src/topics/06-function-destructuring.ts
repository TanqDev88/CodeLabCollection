interface Product {
    description: string;
    price: number;
}

const phone: Product = {
    description: "Noka A1",
    price: 150
}

const tablet: Product = {
    description: "iPad Aire",
    price: 300
}

interface TaxCalculationOptions{
    tax: number;
    products: Product[];
}

function taxCalculation(options: TaxCalculationOptions): number[]{
    let total = 0;

    options.products.forEach(product => {
        total += product.price;
    });
    return[total, total * options.tax];

}

const shoppingCart = [phone, tablet];
const tax = 0.15;

const result = taxCalculation({
    products : shoppingCart,
    tax:  tax,
})

console.log('Total', result[0]);
console.log('Tax', result[1]);



export {};