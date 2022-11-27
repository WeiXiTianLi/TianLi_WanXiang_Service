var path = require('path');
var node_modules = path.resolve(__dirname, 'node_modules');

module.exports = {
    entry: './src/main.js',
    output: {
        path: path.resolve(__dirname, './dist'),
    },
    presets: [
        '@vue/cli-plugin-babel/preset'
      ],
      
    // 第三方插件配置
    pluginOptions: {},
}