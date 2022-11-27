module.exports = {
    content: ['./src/**/*.{vue,js,ts}'],
    theme: {
      extend: {},
    },
    plugins: [require("daisyui")],
      // daisyUI config (optional)
    daisyui: {
        styled: true,
        themes: true,
        base: true,
        utils: true,
        logs: true,
        rtl: false,
        prefix: "",
        darkTheme: "dark",
  },
  }