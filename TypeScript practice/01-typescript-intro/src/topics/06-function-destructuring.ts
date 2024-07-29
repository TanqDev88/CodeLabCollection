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

function taxCalculation(options: TaxCalculationOptions): [number, number]{
    
    const {tax, products} = options;
    
    let total = 0;

    products.forEach(({price}) => {
        total += price;
    });
    return[total, total * options.tax];

}

const shoppingCart = [phone, tablet];
const tax = 0.15;

const [total, tatalTax] = taxCalculation({
    products : shoppingCart,
    tax:  tax,
})

console.log('Total', total);
console.log('Tax', tax);



export {};