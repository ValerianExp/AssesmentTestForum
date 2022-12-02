const { Builder, By, Key } = require("selenium-webdriver");
// require("chromedriver");
const assert = require("assert");

async function seleniumForum() {
  //lanzamos el navegador
  let driver = await new Builder().forBrowser("chrome").build();

  //ponemos nuestra url
  await driver.get("http://localhost:3000/");

  //indicamos lo que vamos a probar buscando por id/etiqueta/classname y pedimos que nos
  //devuelva algún valor para comprobar que realmente funciona
  await driver.findElement(By.className("Name")).sendKeys(Key.RETURN);
  await driver.findElement(By.id("creaPost")).sendKeys(Key.RETURN);
  await driver
    .findElement(By.id("titlepost"))
    .sendKeys("Título de prueba", Key.RETURN);
  await driver
    .findElement(By.id("categorypost"))
    .sendKeys("Categoría de Prueba", Key.RETURN);
  await driver
    .findElement(By.id("post"))
    .sendKeys("Body de prueba", Key.RETURN);
  await driver.findElement(By.id("postit")).sendKeys(Key.RETURN);
  await driver.findElement(By.className("Logo")).sendKeys(Key.RETURN);
}

//devolvemos nuestra funcion de ejemplo
seleniumForum();
