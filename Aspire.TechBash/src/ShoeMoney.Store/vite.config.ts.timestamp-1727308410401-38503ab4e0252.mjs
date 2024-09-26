// vite.config.ts
import { fileURLToPath, URL } from "node:url";
import { defineConfig } from "file:///C:/talks/TechBash/2024/Aspire/after/ShoeMoney.Store/node_modules/vite/dist/node/index.js";
import vue from "file:///C:/talks/TechBash/2024/Aspire/after/ShoeMoney.Store/node_modules/@vitejs/plugin-vue/dist/index.mjs";
import Pages from "file:///C:/talks/TechBash/2024/Aspire/after/ShoeMoney.Store/node_modules/vite-plugin-pages/dist/index.js";
import Components from "file:///C:/talks/TechBash/2024/Aspire/after/ShoeMoney.Store/node_modules/unplugin-vue-components/dist/vite.js";
var __vite_injected_original_import_meta_url = "file:///C:/talks/TechBash/2024/Aspire/after/ShoeMoney.Store/vite.config.ts";
var vite_config_default = defineConfig({
  plugins: [
    vue(),
    Pages({
      routeStyle: "nuxt"
    }),
    Components()
  ],
  resolve: {
    alias: {
      "@": fileURLToPath(new URL("./src", __vite_injected_original_import_meta_url))
    }
  },
  server: {
    host: true,
    port: parseInt(process.env.PORT ?? "5173")
  }
});
export {
  vite_config_default as default
};
//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAic291cmNlcyI6IFsidml0ZS5jb25maWcudHMiXSwKICAic291cmNlc0NvbnRlbnQiOiBbImNvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9kaXJuYW1lID0gXCJDOlxcXFx0YWxrc1xcXFxUZWNoQmFzaFxcXFwyMDI0XFxcXEFzcGlyZVxcXFxhZnRlclxcXFxTaG9lTW9uZXkuU3RvcmVcIjtjb25zdCBfX3ZpdGVfaW5qZWN0ZWRfb3JpZ2luYWxfZmlsZW5hbWUgPSBcIkM6XFxcXHRhbGtzXFxcXFRlY2hCYXNoXFxcXDIwMjRcXFxcQXNwaXJlXFxcXGFmdGVyXFxcXFNob2VNb25leS5TdG9yZVxcXFx2aXRlLmNvbmZpZy50c1wiO2NvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9pbXBvcnRfbWV0YV91cmwgPSBcImZpbGU6Ly8vQzovdGFsa3MvVGVjaEJhc2gvMjAyNC9Bc3BpcmUvYWZ0ZXIvU2hvZU1vbmV5LlN0b3JlL3ZpdGUuY29uZmlnLnRzXCI7aW1wb3J0IHsgZmlsZVVSTFRvUGF0aCwgVVJMIH0gZnJvbSAnbm9kZTp1cmwnXG5cbmltcG9ydCB7IGRlZmluZUNvbmZpZyB9IGZyb20gJ3ZpdGUnXG5pbXBvcnQgdnVlIGZyb20gJ0B2aXRlanMvcGx1Z2luLXZ1ZSdcblxuaW1wb3J0IFBhZ2VzIGZyb20gJ3ZpdGUtcGx1Z2luLXBhZ2VzJztcbmltcG9ydCBDb21wb25lbnRzIGZyb20gXCJ1bnBsdWdpbi12dWUtY29tcG9uZW50cy92aXRlXCI7XG5cbi8vIGh0dHBzOi8vdml0ZWpzLmRldi9jb25maWcvXG5leHBvcnQgZGVmYXVsdCBkZWZpbmVDb25maWcoe1xuICBwbHVnaW5zOiBbXG4gICAgdnVlKCksXG4gICAgUGFnZXMoe1xuICAgICAgcm91dGVTdHlsZTogXCJudXh0XCJcbiAgICB9KSxcbiAgICBDb21wb25lbnRzKCksXG4gIF0sXG4gIHJlc29sdmU6IHtcbiAgICBhbGlhczoge1xuICAgICAgJ0AnOiBmaWxlVVJMVG9QYXRoKG5ldyBVUkwoJy4vc3JjJywgaW1wb3J0Lm1ldGEudXJsKSlcbiAgICB9XG4gIH0sXG4gIHNlcnZlcjoge1xyXG4gICAgaG9zdDogdHJ1ZSxcclxuICAgIHBvcnQ6IHBhcnNlSW50KHByb2Nlc3MuZW52LlBPUlQgPz8gXCI1MTczXCIpXHJcbiAgfVxufSlcbiJdLAogICJtYXBwaW5ncyI6ICI7QUFBeVYsU0FBUyxlQUFlLFdBQVc7QUFFNVgsU0FBUyxvQkFBb0I7QUFDN0IsT0FBTyxTQUFTO0FBRWhCLE9BQU8sV0FBVztBQUNsQixPQUFPLGdCQUFnQjtBQU5vTSxJQUFNLDJDQUEyQztBQVM1USxJQUFPLHNCQUFRLGFBQWE7QUFBQSxFQUMxQixTQUFTO0FBQUEsSUFDUCxJQUFJO0FBQUEsSUFDSixNQUFNO0FBQUEsTUFDSixZQUFZO0FBQUEsSUFDZCxDQUFDO0FBQUEsSUFDRCxXQUFXO0FBQUEsRUFDYjtBQUFBLEVBQ0EsU0FBUztBQUFBLElBQ1AsT0FBTztBQUFBLE1BQ0wsS0FBSyxjQUFjLElBQUksSUFBSSxTQUFTLHdDQUFlLENBQUM7QUFBQSxJQUN0RDtBQUFBLEVBQ0Y7QUFBQSxFQUNBLFFBQVE7QUFBQSxJQUNOLE1BQU07QUFBQSxJQUNOLE1BQU0sU0FBUyxRQUFRLElBQUksUUFBUSxNQUFNO0FBQUEsRUFDM0M7QUFDRixDQUFDOyIsCiAgIm5hbWVzIjogW10KfQo=
