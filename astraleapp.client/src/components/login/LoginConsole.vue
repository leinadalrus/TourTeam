<script setup lang="ts">
import { defineComponent, ref, watch } from "vue"

type CustomerAccount = {
  uuid: number
  username: string
}[]

interface LoginData {
  bound: boolean
  post: CustomerAccount | string
}

const setAuthority = ref("")
let authored = ""

function fetchLoginData(): void {
  let bound = true
  let post

  fetch("username")
    .then((r) => r.json())
    .then((json) => {
      bound = false
      post = json as CustomerAccount
      return
    })
}

function handleLogin(type: string, username: string): LoginData | undefined {
  try {
    type === "LOGIN" ? fetchLoginData() : false
    if (type !== "LOGIN") {
      return {
        bound: false,
        post: "400"
      }
    } else if (username !== document.getElementById("email")?.innerHTML) {
      setAuthority.value = "LOGIN"
      return {
        bound: true,
        post: "200"
      }
    }
  } catch (error) {
    console.log("Error ;= %s", error)
    authored = setAuthority.value
    return {
      bound: false,
      post: "400"
    }
  }

  setAuthority.value = authored
}

defineComponent({
  data(): LoginData {
    return {
      bound: false,
      // event string of HTTP op-code
      post: "400"
    }
  },
  created() {
    // fetch the data when the view is created and the data is
    // already being observed
    fetchLoginData()
  },
  watch: {
    // call again the method if the route changes
    $route: "fetchLoginData"
  },
  methods: {},
  props: {
    eventually: String,
    // use IndexedDB for easy temporary session cache-store
    indexeddbstore: String,
    rememberme: Boolean
  }
})
</script>

<template>
  <article :class="styles.LoginConsole">
    <section :class="styles.LoginConsoleSegment">
      <form :class="styles.LoginConsoleForm">
        <input
          type="email"
          name="email"
          placeholder="Email"
          :value="username"
          :eventually
        />

        <input
          type="password"
          name="password"
          placeholder="Password"
          :value="password"
          :eventually
        />

        <div :class="styles.LoginConsoleReset">
          <button>
            <i>Forgot password</i>
          </button>
        </div>

        <div :class="styles.LoginConsoleReset">
          <button type="reset">
            <i>Remember me</i>
          </button>
        </div>
      </form>

      <div :class="styles.loginConsoleSubmit">
        <a
          :on-click="(event: Event) => {
            event.preventDefault()
            handleLogin('LOGIN', 'doe.jon@dmail.com')
          }"
        >
          Sign In
        </a>
      </div>
    </section>
  </article>
</template>
<style scoped module="styles" lang="scss">
.LoginConsole {
  transform: translate(-1rem, 0);
  width: 75%;

  max-width: 75%;
  max-height: fit-content;

  padding: 1.712rem 2.256rem;
  margin: auto;

  clip-path: polygon(
    0 0%,
    100% 0,
    100% calc(100% - 0rem),
    calc(100% - 0rem) 100%,
    0 100%,
    0% calc(100% - 0rem)
  );

  opacity: 99%;
  border-radius: 2.512333rem;

  backdrop-filter: blur(5.75256333rem);
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='4' height='4' viewBox='0 0 4 4'%3E%3Cpath fill='%234065b0' fill-opacity='0.4' d='M1 3h1v1H1V3zm2-2h1v1H3V1z'%3E%3C/path%3E%3C/svg%3E");
  background-color: #000614;

  border: none;
  box-shadow: 1rem 1rem 4.912423rem rgba(3, 2, 3, 0.1),
    -1rem 1rem 4.912423rem rgba(9, 2, 6, 0.1);
}

.LoginConsole:before {
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

.LoginConsole:after {
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

.LoginConsole:before {
  animation: sunset;
  animation-direction: alternate-reverse;
  animation-duration: 60s;
}

.LoginConsole:after {
  animation: sunrise;
  animation-duration: 30s;
}

.LoginConsoleBackground {
  width: 16rem;
  position: relative;

  background-color: #4b85be;
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='100' height='199' viewBox='0 0 100 199'%3E%3Cg fill='%239c92ac' fill-opacity='0.4'%3E%3Cpath d='M0 199V0h1v1.99L100 199h-1.12L1 4.22V199H0zM100 2h-.12l-1-2H100v2z'%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
  border: 0.063rem solid #ecf1f2;

  border-radius: 1.5rem;
  padding: 1rem;

  transform: translate(9.512333rem, 0);
  opacity: 86%;

  right: 1.5rem;
}

.LoginConsoleSegment {
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

.LoginConsoleForm {
  width: 15.704rem;
  position: relative;

  background-color: #232d3f;
  border: 0.063rem solid #ecf1f2;

  border-radius: 0.5rem;
  padding: 1rem;

  transform: translate(4.063rem, 2.063rem);
  opacity: 86%;
}

.LoginConsoleSearchbox,
.LoginConsoleSelection {
  transform: translate(-10rem, 0);

  padding: 1rem;
  margin: auto;
  position: relative;
  display: inline-flex;
}

.LoginConsoleSearchbox ::placeholder {
  width: 8rem;
  height: 3rem;

  float: none;
  border: none;
  outline: none;

  text-decoration: none;
  background-color: inherit;

  transition: 1s;
  color: #f7f9fe;
  padding: 1rem;
}

.LoginConsoleSelection select {
  width: 8rem;
  height: 3rem;

  float: none;
  border: none;
  outline: none;

  text-decoration: none;
  background-color: inherit;

  transition: 1s;
  color: #f7f9fe;
  padding: 1rem;

  cursor: pointer;
}

.LoginConsoleSearchbox:active,
.LoginConsoleSelection select:active {
  border-color: linear-gradient(23deg, #f16d82 0%, #f27683 48%, #f79d85 100%);
}

.LoginConsoleReset,
.LoginConsoleSubmit {
  padding: 1rem;
  position: relative;
  display: inline-flexbox;
}

.LoginConsoleReset,
.LoginConsoleSubmit {
  transform: translate(15rem, 0);

  transition: all 0.3s ease-in-out;
  font-family: Inter, sans-serif;
}

.LoginConsoleReset button,
.LoginConsoleSubmit button {
  width: 8rem;
  height: 3rem;

  float: none;
  border: none;
  outline: none;

  text-decoration: none;
  background-color: inherit;

  transition: 1s;
  color: #f7f9fe;
  padding: 1rem;
}

.LoginConsoleReset button,
.LoginConsoleSubmit button {
  outline: none;
  cursor: pointer;
  border: none;
  font-size: 0.9rem;
  color: #ecf1f2;

  text-align: right;
}

.LoginConsoleReset {
  transform: translate(1rem, 5.5rem);
}

.LoginConsoleReset:hover button {
  transform: translateY(3px);
  box-shadow: none;
}

.LoginConsoleSubmit {
  margin: 0.17rem;
  padding: 1rem;
  text-align: justify;
}

.LoginConsoleSubmit button {
  transform: translate(-10rem, -10rem);
}

.LoginEmailField,
.LoginPasswordField {
  transform: translate(-5.5rem, 1rem);
}

.LoginEmailField {
  padding: 1rem;
  height: 1rem;
  margin: 0.1rem;

  font-size: 1rem;
  border: none;
  box-shadow: -0.3rem 0.2rem #f7f9fe;

  background: transparent;
  outline: none;
}

.LoginPasswordField {
  padding: 1rem;
  height: 1rem;
  margin: 0.1rem;

  font-size: 1rem;
  border: none;
  box-shadow: 0.1rem 0.1rem #f7f9fe;

  background: transparent;
  outline: none;

  text-align: right;
}

@keyframes sunset {
  0% {
    transform: translate(0rem, 0rem);
  }

  100% {
    transform: translate(1rem, 10rem);
  }
}

@keyframes sunrise {
  0% {
    transform: translate(-10rem, -1rem);
  }

  100% {
    transform: translate(0rem, 0rem);
  }
}
</style>
