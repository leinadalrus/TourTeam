<script setup lang="ts">
import { ref, watch } from "vue"

const username = ref("username")
const password = ref("password")

let authenticated = ref(false)
let sophisticated = ref("\0")

watch(password, async (authentication) => {
  if (authentication) authenticated.value = true

  const response = await fetch("https://tourteam.o/api")

  try {
    sophisticated.value = (await response.json()).sophisticated
  } catch (error: any) {
    authenticated.value = false
  }
}, { flush: "sync", once: true })
</script>

<template>
  <article class="login-console">
    <section class="login-console-segment">
      <form class="login-console-form">
        <input type="email" name="email" placeholder="Username?" value="username" class="login-email-field"
          v-model.trim="username" />

        <input type="password" name="password" placeholder="Password...?" value="password" class="login-password-field"
          v-model.trim="password" />

        <div class="login-console-reset">
          <button>
            <i>Forgot password</i>
          </button>
        </div>

        <div class="login-console-reset">
          <button type="reset">
            <i>Remember me</i>
          </button>
        </div>
      </form>

      <div class="login-console-submit">
        <a>
          Sign In
        </a>
      </div>
    </section>
  </article>
</template>

<style scoped lang="scss">
.login-console {
  max-width: 75%;
  max-height: fit-content;
  padding: 1.712rem 2.256rem;
  margin: auto;
  opacity: 99%;
  border: none;
  border-radius: 2.512333rem;
  backdrop-filter: blur(5.75256333rem);
  background-color: #000614;
  box-shadow: 1rem 1rem 4.912423rem rgba(3, 2, 3, 0.1),
    -1rem 1rem 4.912423rem rgba(9, 2, 6, 0.1);
  :before {
    width: 25rem;
    height: 25rem;
    position: absolute;
    z-index: -1;
    background-color: #bed2d9;
    border-radius: 50rem;
    filter: blur(5rem);
    backdrop-filter: blur(2.5rem);
    border: none;
    box-shadow: 1rem 1rem 5rem #121118, -1rem 1rem 5rem #191624;
    content: "";
    opacity: 50%;
  }
  :after {
    width: 20rem;
    height: 20rem;
    top: 23rem;
    left: 12rem;
    right: 7rem;
    position: absolute;
    z-index: -1;
    background-color: #fc9d9a;
    border-radius: 10rem;
    filter: blur(5rem);
    backdrop-filter: blur(2.5rem);
    border: none;
    box-shadow: 1rem 1rem 1rem #ecf1f2, -1rem 1rem 1rem #f7f9fe;
    content: "";
    opacity: 50%;
  }
}

.login-console-segment {
  clip-path: polygon(
    2rem 0%,
    100% 0,
    100% calc(100% - 2rem),
    calc(100% - 2rem) 100%,
    0 100%,
    0% 2rem
  );
  width: 15.704rem;
  position: relative;
  background-color: #232d3f;
  border: 0.063rem solid #ecf1f2;
  border-radius: 0.5rem;
  padding: 1rem;
  transform: translate(5rem, 1rem);
  opacity: 86%;
}

.login-console-form {
  width: 15.704rem;
  position: relative;
  background-color: #232d3f;
  border: 0.063rem solid #ecf1f2;
  border-radius: 0.5rem;
  padding: 1rem;
  transform: translate(4.063rem, 2.063rem);
  opacity: 86%;
}

.login-console-action {
  button {
    width: 8rem;
    height: 3rem;
    padding: 1rem;
    position: relative;
    display: inline-flexbox;
    transform: translate(-10rem, -10rem);
    float: none;
    border: none;
    outline: none;
    text-align: right;
    text-decoration: none;
    background-color: inherit;
    font-family: Inter, sans-serif;
    font-size: 0.9rem;
    cursor: pointer;
    transition: 1s;
    color: #ecf1f2;
  }
  :hover {
    transform: translateY(3px);
    box-shadow: none;
  }
}

.login-email-field,
.login-password-field {
  padding: 1rem;
  height: 1rem;
  margin: 0.1rem;
  font-size: 1rem;
  border: none;
  box-shadow: -0.3rem 0.2rem #f7f9fe;
  background: transparent;
  outline: none;
}
</style>
