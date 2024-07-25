import './style.css'
import './topics/01-basic-types.ts';
import './topics/02-object-iterface.ts'

document.querySelector<HTMLDivElement>('#app')!.innerHTML = `Hello World`

document.querySelector<HTMLDivElement>('#app')!.innerHTML = `Hello world`
console.log('Hello word on the console')