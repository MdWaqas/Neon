module.exports = {
  root: true,
  env: {
    browser: true, 
    es6: true,
    node: true
  },
  extends: ["plugin:vue/recommended", "@vue/prettier"],
  parserOptions: {
    parser: "babel-eslint", 
    ecmaVersion: 2018,
    sourceType: "module"
  },
  plugins:[
    'vue'
  ],
  rules: {
    "no-console": process.env.NODE_ENV === "production" ? "warn" : "off",
    "no-debugger": process.env.NODE_ENV === "production" ? "warn" : "off"
  }
};
